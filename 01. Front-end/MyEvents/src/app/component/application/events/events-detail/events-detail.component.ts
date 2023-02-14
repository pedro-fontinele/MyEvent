import { EActions } from '@app/common/enum/message/actions/actions-enums';
import { ToastrService } from 'ngx-toastr';
import { NgxSpinnerService } from 'ngx-spinner';
import { EventService } from './../../../../service/events/event.service';
import { EButton } from 'src/app/common/enum/button/button';
import { EAlert } from './../../../../common/enum/message/alert/alert-enums';
import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { EventTableFieldsFields } from '../../application-fields/event-fields/event-table/event-table-fields';
import { ActivatedRoute, Router } from '@angular/router';
import { Event } from '@app/common/model/event';
import { Batch } from '@app/common/model/batch';
import { BsLocaleService } from 'ngx-bootstrap/datepicker';
import { EMessage } from '@app/common/enum/message/message/message-enums';
import { BatchDetailFields } from '../../application-fields/event-fields/batch-detail/batch-detail-fields';
import { BatchService } from '@app/service/batch/batch.service';

@Component({
  selector: 'app-events-detail',
  templateUrl: './events-detail.component.html',
  styleUrls: ['./events-detail.component.css']
})
export class EventsDetailComponent implements OnInit {

  public eventTableFields: EventTableFieldsFields;
  public batchDetailFields: BatchDetailFields;
  public form!: FormGroup;
  public event!: Event;
  public batch!: Batch;
  public eventExists: boolean = false;
  public fieldIsRequired = EAlert.FieldIsRequired;
  public exceededNumberOfCharacters = EAlert.ExceededNumberOfCharacters;
  public emailNotValidated = EAlert.EmailNotValidated;
  public newButton: string = EButton.New;
  public deleteButton: string = EButton.Delete;
  public doneButton = EButton.Done;
  public cancelButton = EButton.Cancel;
  public errorLoadingData = EMessage.ErrorLoadingData;
  public error = EMessage.Error;
  public savedRecord = EActions.SavedRecord;
  public anErrorOccurredWhileSavingTheRecord = EActions.AnErrorOccurredWhileSavingTheRecord;
  public newRecordSuccessfullySaved = EActions.NewRecordSuccessfullySaved;
  
  get batchs(): FormArray{
    return this.form.get('batchs') as FormArray;
  }

  constructor (private formBuilder: FormBuilder, 
               private activatedRoute: ActivatedRoute,  
               public router: Router,
               private eventService: EventService, 
               private batchService: BatchService,
               private localeService: BsLocaleService, 
               private spinner: NgxSpinnerService, 
               private toastr: ToastrService){
    this.eventTableFields = new EventTableFieldsFields();
    this.batchDetailFields = new BatchDetailFields();
    this.localeService.use('en-us');
  }

  public ngOnInit(): void{ 
    this.validationForm();
    this.loadEventDetail();
  }

  public validationForm(): void{
    this.form = this.formBuilder.group({
      theme: ['', [Validators.required, Validators.maxLength(250)]],
      local: ['', [Validators.required, Validators.maxLength(150)]],
      eventDate: ['', [Validators.required, Validators.maxLength(19)]],
      numberOfParticipants: ['', [Validators.required, Validators.maxLength(5)]],
      telephone: ['', [Validators.required, Validators.maxLength(13)]],
      email: ['', [Validators.required, Validators.email]],
      imageUrl: ['', Validators.required],
      batchs: this.formBuilder.array([])
    });
  }

  public addBatch(): void{
    this.batchs.push(this.createBacth({ id: 0 } as unknown as Batch));
  }

  public createBacth (batch: Batch): FormGroup{
    return this.formBuilder.group({
        idBatch: [batch.idBatch],
        name: [batch.name, Validators.required],
        theAmount: [batch.theAmount, Validators.required],
        price: [batch.price, Validators.required],
        startDate: [batch.startDate], 
        endDate: [batch.endDate]   
    });
  }

  public cancelFromEvent(): void{
    this.form.reset();
  }

  public cancelFromBatch(): void{
    this.batchs.reset();
  }

  public configurationDatePicker(): any {     
  return {
      isAnimated: true,
      adaptivePosition: true, 
      dateInputFormat: 'DD/MM/YYYY HH:mm',
      containerClass :'theme-default',
      showWeekNumbers: false,
      withTimepicker: true
    };    
  }

  public loadEventDetail (): void {
    const idEvent = this.activatedRoute.snapshot.paramMap.get('id');
    if (idEvent !== null) {
      this.spinner.show();
      this.eventService.getEventsById(+idEvent).subscribe({
          next: (response: Event) => {
            this.event = response;
            this.form.patchValue(this.event);
            this.eventExists = true;
          },
          error: (erro: any) => {
            this.spinner.hide();
            this.toastr.error(this.errorLoadingData, this.error)
            console.error(erro);
          },
          complete: () => {
            this.spinner.hide();
          }
     });
    }
   }

   public saveBatchRecord(): void{
    this.spinner.show();
    if (this.form.valid) {
        this.batch = {...this.form.value};
        const idEvent = this.activatedRoute.snapshot.paramMap.get('id');
        if (idEvent !== null) {
          this.putBatch(+idEvent, this.batch);
        } else {
          this.postBatch(this.batch);
        }
      }
   }

   public putBatch(idEvent: number, batch: Batch){
    this.batchService.putBatchs(idEvent, batch).subscribe(
      (batchReturned: Batch) => {
        this.spinner.hide();
        this.toastr.success(this.newRecordSuccessfullySaved, this.savedRecord);
        this.router.navigate([`events/detail/${batchReturned.idEvent}`]);
      },
      (erro: any) => {
        this.spinner.hide();
        this.toastr.error(this.anErrorOccurredWhileSavingTheRecord, this.error);
        console.error(erro);
      }
     );
  }

  public postBatch(batch: Batch){
    this.batchService.postBatchs(batch).subscribe(
      (batchReturned: Batch) => {
        this.spinner.hide();
        this.toastr.success(this.newRecordSuccessfullySaved, this.savedRecord);
        this.router.navigate(['events/list/']);
      },
      (erro: any) => {
        this.spinner.hide();
        this.toastr.error(this.anErrorOccurredWhileSavingTheRecord, this.error);
        console.error(erro);
      }
     );
  }

   public saveEventRecord(): void{
    this.spinner.show();
    if (this.form.valid) {
        this.event = {...this.form.value};
        const idEvent = this.activatedRoute.snapshot.paramMap.get('id');
        if (idEvent !== null) {
          this.putEvent(+idEvent, this.event);
        } else {
          this.postEvent(this.event);
        }
      }
   }

   public putEvent(idEvent: number, event: Event): void{
      this.eventService.putEvents(idEvent, event).subscribe({
        next: () => {
          this.spinner.hide();
        },
        error: (erro: any) => {
          this.spinner.hide();
          this.toastr.error(this.anErrorOccurredWhileSavingTheRecord, this.error);
          console.error(erro);
        },
        complete: () => {
          this.toastr.success(this.newRecordSuccessfullySaved, this.savedRecord);
          this.router.navigate(['events/list/']);
        }
       });
    }

    public postEvent(event: Event){
      this.eventService.postEvents(event).subscribe(
        (event: Event) => {
          this.spinner.hide();
          this.toastr.success(this.newRecordSuccessfullySaved, this.savedRecord);
          this.router.navigate([`events/detail/${event.idEvent}`]);
        },
        (erro: any) => {
          this.spinner.hide();
          this.toastr.error(this.anErrorOccurredWhileSavingTheRecord, this.error);
          console.error(erro);
        }
       );
    }
}
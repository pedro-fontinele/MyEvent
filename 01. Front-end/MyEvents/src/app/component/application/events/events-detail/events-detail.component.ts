import { EActions } from '@app/common/enum/message/actions/actions-enums';
import { ToastrService } from 'ngx-toastr';
import { NgxSpinnerService } from 'ngx-spinner';
import { EventService } from './../../../../service/events/event.service';
import { EButton } from 'src/app/common/enum/button/button';
import { EAlert } from './../../../../common/enum/message/alert/alert-enums';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { EventTableFieldsFields } from '../../application-fields/event-fields/event-table/event-table-fields';
import { ActivatedRoute, Router } from '@angular/router';
import { Event } from '@app/common/model/event';
import { BsLocaleService } from 'ngx-bootstrap/datepicker';
import { EMessage } from '@app/common/enum/message/message/message-enums';

@Component({
  selector: 'app-events-detail',
  templateUrl: './events-detail.component.html',
  styleUrls: ['./events-detail.component.css']
})
export class EventsDetailComponent implements OnInit {

  public eventTableFields: EventTableFieldsFields;
  public form!: FormGroup;
  public event!: Event;
  public fieldIsRequired = EAlert.FieldIsRequired;
  public exceededNumberOfCharacters = EAlert.ExceededNumberOfCharacters;
  public emailNotValidated = EAlert.EmailNotValidated;
  public doneButton = EButton.Done;
  public cancelButton = EButton.Cancel;
  public errorLoadingData = EMessage.ErrorLoadingData;
  public error = EMessage.Error;
  public savedRecord = EActions.SavedRecord;
  public anErrorOccurredWhileSavingTheRecord = EActions.AnErrorOccurredWhileSavingTheRecord;
  public newRecordSuccessfullySaved = EActions.NewRecordSuccessfullySaved;
  
  constructor (private formBuilder: FormBuilder, private activatedRoute: ActivatedRoute,  public router: Router, private eventService: EventService, private localeService: BsLocaleService, private spinner: NgxSpinnerService, private toastr: ToastrService){
    this.eventTableFields = new EventTableFieldsFields()
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
      imageUrl: ['', Validators.required]
    });
  }

  public cancelFrom(): void{
    this.form.reset();
  }

  public configurationDatePicker(): any {     
  return {
      isAnimated: true,
      adaptivePosition: true, 
      dateInputFormat: 'DD/MM/YYYY hh:mm a',
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
            this.form.patchValue(this.event)
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


   public saveRecord(): void{
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

    public postEvent(event: Event): void{
      this.eventService.postEvents(event).subscribe({
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
}
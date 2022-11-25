import { EButton } from 'src/app/common/enum/button/button';
import { EAlert } from './../../../../common/enum/message/alert/alert-enums';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { eventTableFieldsFields } from '../../application-fields/event-fields/event-table/event-table-fields';

@Component({
  selector: 'app-events-detail',
  templateUrl: './events-detail.component.html',
  styleUrls: ['./events-detail.component.css']
})
export class EventsDetailComponent implements OnInit {

  constructor(private formBuilder: FormBuilder) {
   this.eventTableFields = new eventTableFieldsFields()
  }

  ngOnInit() { 
    this.validationForm();
  }

  public eventTableFields: eventTableFieldsFields;
  public form!: FormGroup;
  public fieldIsRequired = EAlert.FieldIsRequired;
  public exceededNumberOfCharacters = EAlert.ExceededNumberOfCharacters;
  public emailNotValidated = EAlert.EmailNotValidated;
  public doneButton = EButton.Done;
  public cancelButton = EButton.Cancel;

  public validationForm(): void{
    this.form = this.formBuilder.group({
      theme: ['', [Validators.required, Validators.maxLength(250)]],
      local: ['', [Validators.required, Validators.maxLength(150)]],
      dateEvent: ['', [Validators.required, Validators.maxLength(11)]],
      numberOfParticipants: ['', [Validators.required, Validators.maxLength(5)]],
      telephone: ['', [Validators.required, Validators.maxLength(13)]],
      email: ['', [Validators.required, Validators.email]],
      imageUrl: ['', Validators.required]
    });
  }

  public cancelFrom(): void{
    this.form.reset();
  }

}
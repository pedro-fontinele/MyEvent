import { EButton } from 'src/app/common/enum/button/button';
import { Component, OnInit } from '@angular/core';
import { PorfileFields } from '@app/component/application/application-fields/user-fields/porfile-fields/porfile-fields';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { EAlert } from '@app/common/enum/message/alert/alert-enums';

@Component({
  selector: 'app-porfile-form',
  templateUrl: './porfile-form.component.html',
  styleUrls: ['./porfile-form.component.css']
})
export class PorfileFormComponent implements OnInit {

  constructor(private formBuilder: FormBuilder) { 
    this.porfileFields = new PorfileFields();
  }

  ngOnInit(): void{
    this.validationFrom();
  }

  public porfileFields: PorfileFields;
  public cancelButton = EButton.Cancel;
  public doneButton = EButton.Done;
  public form!: FormGroup;
  public fieldIsRequired = EAlert.FieldIsRequired;
  public exceededNumberOfCharacters = EAlert.ExceededNumberOfCharacters;

  public validationFrom(): void{
    this.form = this.formBuilder.group({
      title: ['', Validators.required],
      fristName: ['', [Validators.required, Validators.maxLength(30)]],
      lastName: ['', [Validators.required, Validators.maxLength(30)]],
      email: ['', [Validators.required, Validators.email]],
      telephone: ['', [Validators.required, Validators.maxLength(13)]],
      function: ['', Validators.required],
      description: ['', [Validators.required, Validators.maxLength(250)]],
      password: ['', [Validators.required, Validators.maxLength(15)]],
      confirmPassword: ['', [Validators.required, Validators.maxLength(15)]]
    });
  }

  public cancelFrom(): void{
    this.form.reset();
  }

}

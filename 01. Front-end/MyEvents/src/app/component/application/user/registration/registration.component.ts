import { EButton } from 'src/app/common/enum/button/button';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { RegistrationFields } from '../../application-fields/registration-fields/registration-fields';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { EAlert } from '@app/common/enum/message/alert/alert-enums';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  constructor(public router: Router, public formBuilder: FormBuilder) {
    this.registrationFields = new RegistrationFields();
  }

  ngOnInit() { 
    this.validationForm();
  }

  public form!: FormGroup;
  public doneButton = EButton.Done;
  public registrationFields: RegistrationFields;
  public fieldIsRequired = EAlert.FieldIsRequired;
  public emailNotValidated = EAlert.EmailNotValidated;
  public alreadyRegisteredButton = EButton.AlreadyRegistered;
  public exceededNumberOfCharacters = EAlert.ExceededNumberOfCharacters;

  public routerLogin(): void {
    this.router.navigate(['/user/login']);
  }

  public validationForm(): void{
    this.form = this.formBuilder.group({
      fristName: ['', [Validators.required, Validators.maxLength(30)]],
      lastName: ['', [Validators.required, Validators.maxLength(30)]],
      email: ['', [Validators.required, Validators.maxLength(30), Validators.email]],
      user: ['', [Validators.required, Validators.maxLength(20)]],
      password: ['', [Validators.required, Validators.maxLength(15)]],
      confirmPassword: ['', [Validators.required, Validators.maxLength(15)]],
      iAgreeWith: ['', Validators.required]
    });
  }

}

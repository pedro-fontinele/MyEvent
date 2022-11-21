import { ProfileComponent } from './component/application/user/profile/profile.component';
import { EventsDetailComponent } from './component/application/events/events-detail/events-detail.component';
import { EventService } from './service/event.service';
import { CUSTOM_ELEMENTS_SCHEMA, NgModule, Component } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventsComponent } from './component/application/events/events.component';
import { SpeakersComponent } from './component/application/speakers/speakers.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavBarComponent } from './component/navegation/element/nav-bar/nav-bar.component';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { FormsModule } from '@angular/forms';
import { DateFormatPipe } from './common/pipe/date-format.pipe';
import { AccountComponent } from './component/navegation/element/account/account.component';
import { EventsTableComponent } from './component/application/events/events-table/events-table.component';
import { EventsFormComponent } from './component/application/events/events-form/events-form.component';
import { ButtonEditComponent } from './component/navegation/element/button/button-edit/button-edit.component';
import { ButtonDeleteComponent } from './component/navegation/element/button/button-delete/button-delete.component';
import { ButtonShowOrHideComponent } from './component/navegation/element/button/button-show-or-hide-image/button-show-or-hide-image.component';
import { ApplicationEventsTitleComponent } from './component/application/events/events-title/events-title.component';
import { ModalModule } from 'ngx-bootstrap/modal';
import { ToastrModule } from 'ngx-toastr';
import { NgxSpinnerModule } from "ngx-spinner";
import { UserComponent } from './component/application/user/user.component';
import { LoginComponent } from './component/application/user/login/login.component';
import { RegistrationComponent } from './component/application/user/registration/registration.component';
import { PorfileTitleComponent } from './component/application/user/profile/porfile-title/porfile-title.component';
import { PorfileFormComponent } from './component/application/user/profile/porfile-form/porfile-form.component';


@NgModule({
  declarations: [
    AppComponent,
    EventsComponent,
    SpeakersComponent,
    NavBarComponent,
    DateFormatPipe,
    AccountComponent,
    EventsTableComponent,
    EventsFormComponent,
    ApplicationEventsTitleComponent,
    ButtonEditComponent,
    ButtonDeleteComponent,
    ButtonShowOrHideComponent,
    EventsDetailComponent,
    UserComponent,
    LoginComponent,
    RegistrationComponent,
    PorfileTitleComponent,
    PorfileFormComponent,
    ProfileComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    CollapseModule.forRoot(),
    BsDropdownModule.forRoot(),
    ModalModule.forRoot(),
    ToastrModule.forRoot({
          timeOut: 3000,
          positionClass: 'toast-bottom-right',
          preventDuplicates: true,
          progressBar:  true
    }),
    NgxSpinnerModule.forRoot(),
    FormsModule
  ],
  providers: [
    EventService
  ],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule { }

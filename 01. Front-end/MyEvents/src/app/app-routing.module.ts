import { RegistrationComponent } from './component/application/user/registration/registration.component';
import { LoginComponent } from './component/application/user/login/login.component';
import { EventsFormComponent } from './component/application/events/events-form/events-form.component';
import { EventsTableComponent } from './component/application/events/events-table/events-table.component';
import { EventsDetailComponent } from './component/application/events/events-detail/events-detail.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EventsComponent } from './component/application/events/events.component';
import { SpeakersComponent } from './component/application/speakers/speakers.component';
import { DashboardComponent } from './component/application/dashboard/dashboard.component';
import { ContactsComponent } from './component/application/contacts/contacts.component';
import { ProfileComponent } from './component/application/user/profile/profile.component';
import { UserComponent } from './component/application/user/user.component';

const routes: Routes = [
   {
    path: 'user', component: UserComponent,
    children: [
      {path: 'login', component: LoginComponent},
      {path: 'registration', component: RegistrationComponent}
    ]
   },
   {path: 'user/profile', component: ProfileComponent },   
   {path: 'events', redirectTo: 'events/list'},
   {
    path: 'events', component: EventsComponent,
    children: [
      {path: 'detail/:id', component: EventsDetailComponent},
      {path: 'detail', component: EventsDetailComponent},
      {path: 'list', component: EventsTableComponent}
    ]
   },  
   {path: 'speakers', component: SpeakersComponent},  
   {path: 'dashboard', component: DashboardComponent},  
   {path: 'contacts', component: ContactsComponent},  
   {path: 'profile', component: ProfileComponent},
   {path: '', redirectTo: 'dashboard', pathMatch: 'full'}, 
   {path: '**', redirectTo: 'dashboard', pathMatch: 'full'}  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

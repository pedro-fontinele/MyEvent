import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EventsComponent } from './component/application/events/events.component';
import { SpeakersComponent } from './component/application/speakers/speakers.component';
import { DashboardComponent } from './component/application/dashboard/dashboard.component';
import { ContactsComponent } from './component/application/contacts/contacts.component';
import { ProfileComponent } from './component/application/profile/profile.component';

const routes: Routes = [
   {path: 'events', component: EventsComponent},  
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

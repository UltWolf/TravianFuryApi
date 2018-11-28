import { RegistrationComponent } from './account/registration/registration.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProfileComponent } from './tasks/profile/profile.component';

const routes: Routes = [
  { path: 'registration', component: RegistrationComponent},
  {path: 'profiles', component: ProfileComponent},
  {path: '*', component: RegistrationComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

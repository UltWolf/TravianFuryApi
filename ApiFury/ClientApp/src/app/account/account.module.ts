import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegistrationComponent } from './registration/registration.component';
import { AuthComponent } from './auth/auth.component';
import { ProfileComponent } from './profile/profile.component';
import { AccountRoutingModule } from './account-routing.module';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [RegistrationComponent, AuthComponent, ProfileComponent],
  imports: [
    CommonModule,
    FormsModule,
    AccountRoutingModule
  ],
})
export class AccountModule { }

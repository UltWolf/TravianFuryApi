
import { NgModule, ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegistrationComponent } from './registration/registration.component';





const routes: ModuleWithProviders = RouterModule.forChild([
    { path: 'register', component: RegistrationComponent }
]);



@NgModule({

    imports: [routes],

    exports: [RouterModule]

})

export class AccountRoutingModule { }
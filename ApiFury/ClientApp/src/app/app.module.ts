import { MarketTaskComponent } from './tasks/market-task/market-task.component';
import { WarTaskComponent } from './tasks/war-task/war-task.component';
import { ProfileComponent } from './tasks/profile/profile.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { WarTask, WarTaskForDB } from 'src/app/Models/WarTask';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegistrationComponent } from './account/registration/registration.component';
import { FormsModule } from '@angular/forms';
import { UnderWarTaskComponent } from './tasks/under-war-task/under-war-task.component';


@NgModule({
  declarations: [
    AppComponent,
    RegistrationComponent,
    ProfileComponent,
    WarTaskComponent,
    MarketTaskComponent,
    UnderWarTaskComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [WarTaskComponent,UnderWarTaskComponent,WarTaskForDB],
  bootstrap: [AppComponent]
})
export class AppModule { }

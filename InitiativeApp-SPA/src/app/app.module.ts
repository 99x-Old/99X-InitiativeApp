import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AuthService } from './_services/auth.service';
import { RegisterComponent } from './register/register.component';
import { HomeComponent } from './home/home.component';
import { MembersComponent } from './members/members.component';
import { InitiativesComponent } from './initiatives/initiatives.component';
import { appRoutes } from './routes';
import { MeetingsComponent } from './meetings/meetings.component';
import { ReviewCycleComponent } from './review-cycle/review-cycle.component';

@NgModule({
  declarations: [								
    AppComponent,
      NavComponent,
      RegisterComponent,
      HomeComponent,
      MembersComponent,
      InitiativesComponent,
      MeetingsComponent,
      ReviewCycleComponent
   ],
  imports: [
	BrowserModule,
	CommonModule,
	FormsModule,
	ReactiveFormsModule,
	HttpClientModule,
	BsDropdownModule.forRoot(),
	RouterModule.forRoot(appRoutes)
  ],
  providers: [
	  AuthService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

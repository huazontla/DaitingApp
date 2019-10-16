import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'; // modulo para hacer peticiones HTTP

import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component';

@NgModule({
   declarations: [
      AppComponent,
      ValueComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }

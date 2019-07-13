import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';

import { UsuarioHomeModule } from './usuario/views/home/home.module';

@NgModule({
  declarations: [AppComponent],
  imports: [
    AppRoutingModule,
    BrowserModule,
    UsuarioHomeModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

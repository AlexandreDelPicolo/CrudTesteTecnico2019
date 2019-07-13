import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { UsuarioHeaderComponent } from './usuario-header.component';

@NgModule({
    declarations: [
        UsuarioHeaderComponent
    ],
    imports: [
        BrowserModule
    ], exports: [
        UsuarioHeaderComponent
    ]
})
export class UsuarioHeaderModule { }

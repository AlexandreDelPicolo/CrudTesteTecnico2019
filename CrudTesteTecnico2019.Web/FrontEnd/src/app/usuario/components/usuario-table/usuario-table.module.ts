import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { UsuarioTableComponent } from './usuario-table.component';

@NgModule({
    declarations: [
        UsuarioTableComponent
    ],
    imports: [
        BrowserModule
    ], exports: [
        UsuarioTableComponent
    ]
})
export class UsuarioTableModule { }

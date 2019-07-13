import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { UsuarioModalComponent } from './usuario-modal.component';

@NgModule({
    declarations: [
        UsuarioModalComponent
    ],
    imports: [
        BrowserModule
    ], exports: [
        UsuarioModalComponent
    ]
})
export class UsuarioModalModule { }

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { UsuarioModalComponent } from './usuario-modal.component';
import { UsuarioRepository } from '../../repository/usuario-repository';

@NgModule({
    declarations: [
        UsuarioModalComponent
    ],
    imports: [
        BrowserModule
    ], exports: [
        UsuarioModalComponent
    ],
    providers: [
        UsuarioRepository
    ]
})
export class UsuarioModalModule { }

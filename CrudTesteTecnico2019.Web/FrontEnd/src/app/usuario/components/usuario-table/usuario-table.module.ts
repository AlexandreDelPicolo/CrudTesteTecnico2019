import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { UsuarioTableComponent } from './usuario-table.component';
import { UsuarioRepository } from '../../repository/usuario-repository';

@NgModule({
    declarations: [
        UsuarioTableComponent
    ],
    imports: [
        BrowserModule
    ], exports: [
        UsuarioTableComponent
    ],
    providers: [
        UsuarioRepository
    ]
})
export class UsuarioTableModule { }

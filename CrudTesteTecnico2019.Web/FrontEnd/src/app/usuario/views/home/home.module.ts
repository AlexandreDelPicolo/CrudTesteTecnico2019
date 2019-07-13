import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HomeComponent } from './home.component';
import { UsuarioHeaderModule } from '../../components/usuario-header/usuario-header.module';
import { UsuarioFooterModule } from '../../components/usuario-footer/usuario-footer.module';
import { UsuarioModalModule } from '../../components/usuario-modal/usuario-modal.module';
import { UsuarioTableModule } from '../../components/usuario-table/usuario-table.module';

@NgModule({
    declarations: [
        HomeComponent
    ],
    imports: [
        BrowserModule,
        UsuarioHeaderModule,
        UsuarioFooterModule,
        UsuarioModalModule,
        UsuarioTableModule
    ], exports: [
        HomeComponent
    ]
})
export class UsuarioHomeModule { }

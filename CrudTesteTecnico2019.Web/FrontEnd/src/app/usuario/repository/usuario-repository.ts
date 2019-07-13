import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UsuarioModel } from '../models/usuario.model';
import { Observable } from 'rxjs';

@Injectable()
export class UsuarioRepository {

    private readonly urlApi = 'http://localhost:55827/v1/usuario/';

    constructor(private readonly http: HttpClient) { }

    listar(): Observable<UsuarioModel> {
        return this.http.get<UsuarioModel>(`${this.urlApi}`);
    }

    adionar(usuario: UsuarioModel): Observable<any> {
        return this.http.post<UsuarioModel>(`${this.urlApi}`, usuario);
    }

    editar(usuario: UsuarioModel): Observable<any> {
        return this.http.put<UsuarioModel>(`${this.urlApi}${usuario.Id}`, usuario);
    }

    remover(usuario: UsuarioModel): Observable<any> {
        return this.http.delete<UsuarioModel>(`${this.urlApi}${usuario.Id}`);
    }
}

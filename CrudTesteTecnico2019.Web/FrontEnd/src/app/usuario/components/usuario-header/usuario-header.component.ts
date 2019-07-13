import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-usuario-header',
  templateUrl: './usuario-header.component.html'
})
export class UsuarioHeaderComponent {

  @Input() ListaItens: string[] = [];

  constructor() { }

}

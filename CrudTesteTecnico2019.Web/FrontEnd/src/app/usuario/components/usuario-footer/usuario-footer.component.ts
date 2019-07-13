import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-usuario-footer',
  templateUrl: './usuario-footer.component.html'
})
export class UsuarioFooterComponent {
  @Input() texto = 'Alexandre Del Picolo - Crud teste técnico 2019';
}

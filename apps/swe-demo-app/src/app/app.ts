import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';

@Component({
  imports: [RouterModule],
  selector: 'app-root',
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected title = 'swe-demo-app';
  constructor() {
    console.log(import.meta.env['NG_APP_TEST_VALUE']);
  }
}

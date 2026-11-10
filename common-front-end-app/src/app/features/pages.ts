import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'pages',
  templateUrl: './pages.html',
  styleUrl: './pages.scss',
  imports: [RouterOutlet],
})
export class Pages {}

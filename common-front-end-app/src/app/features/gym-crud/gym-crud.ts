import { ChangeDetectionStrategy, Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { NgSelectComponent } from '@ng-select/ng-select';

@Component({
  selector: 'app-gym-crud',
  imports: [RouterModule, NgSelectComponent],
  templateUrl: './gym-crud.html',
  styleUrl: './gym-crud.scss',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class GymCrud {
  membership = [
    { value: 1, label: 'Yearly' },
    { value: 2, label: 'Monthly' },
    { value: 3, label: 'Weekly' },
  ];
}

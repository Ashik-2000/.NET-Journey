import { Routes } from '@angular/router';
import { GymAddEdit } from './gym-add-edit/gym-add-edit';
import { GymCrud } from './gym-crud';

export const routes: Routes = [
  { path: '', redirectTo: 'list', pathMatch: 'full' },
  {
    path: 'list',
    component: GymCrud,
  },
  {
    path: 'create',
    component: GymAddEdit,
  },
];

import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'pages',
    pathMatch: 'full',
  },
  {
    path: 'pages',
    loadChildren: () => import('./features/pages.route').then((m) => m.routes),
  },
  {
    path: '**',
    redirectTo: 'pages',
  },
];

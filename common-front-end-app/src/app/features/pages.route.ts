import { Routes } from '@angular/router';
import { Layout } from '../core/layout/layout';
import { Pages } from './pages';

export const routes: Routes = [
  {
    path: '',
    component: Pages,
    children: [
      {
        path: '',
        component: Layout,
        children: [
          {
            path: '',
            loadChildren: () => import('./welcome/welcome.route').then((m) => m.routes),
          },
          {
            path: 'gym-crud',
            loadChildren: () => import('./gym-crud/gym-crud.route').then((m) => m.routes),
          },
        ],
      },
    ],
  },
];

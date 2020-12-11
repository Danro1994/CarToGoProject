import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'home',
    pathMatch: 'full'
  },
  {
    path: 'home',
    loadChildren: () => import('./home/home.module').then( m => m.HomePageModule)
  },
  {
    path: 'folder/:id',
    loadChildren: () => import('./folder/folder.module').then( m => m.FolderPageModule)
  },
  {
    path: 'carro/crear',
    loadChildren: () => import('./crear-carro/crear-carro.module').then( m => m.CrearCarroPageModule)
  },
  {
    path: 'carro/editar',
    loadChildren: () => import('./editar-carro/editar-carro.module').then( m => m.EditarCarroPageModule)
  },
  {
    path: 'carros',
    loadChildren: () => import('./carros/carros.module').then( m => m.CarrosPageModule)
  },
  {
    path: 'models',
    loadChildren: () => import('./models/models.module').then( m => m.ModelsPageModule)
  },
  {
    path: 'models/crear',
    loadChildren: () => import('./crear-model/crear-model.module').then( m => m.CrearModelPageModule)
  },
  {
    path: 'models/editar',
    loadChildren: () => import('./editar-model/editar-model.module').then( m => m.EditarModelPageModule)
  },
  {
    path: 'brands',
    loadChildren: () => import('./brands/brands.module').then( m => m.BrandsPageModule)
  },
  {
    path: 'brands/editar',
    loadChildren: () => import('./editar-brand/editar-brand.module').then( m => m.EditarBrandPageModule)
  },
  {
    path: 'brands/crear',
    loadChildren: () => import('./crear-brand/crear-brand.module').then( m => m.CrearBrandPageModule)
  }


  

];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {}

import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'home',
    pathMatch: 'full'
  },
  {
    path: 'folder/:id',
    loadChildren: () => import('./folder/folder.module').then( m => m.FolderPageModule)
  },
  {
    path: 'home',
    loadChildren: () => import('./home/home.module').then( m => m.HomePageModule)
  },  {
    path: 'carro-usado',
    loadChildren: () => import('./carro-usado/carro-usado.module').then( m => m.CarroUsadoPageModule)
  },
  {
    path: 'carro-nuevo',
    loadChildren: () => import('./carro-nuevo/carro-nuevo.module').then( m => m.CarroNuevoPageModule)
  },
  {
    path: 'concesionaria',
    loadChildren: () => import('./concesionaria/concesionaria.module').then( m => m.ConcesionariaPageModule)
  },
  {
    path: 'videos-instructivos',
    loadChildren: () => import('./videos-instructivos/videos-instructivos.module').then( m => m.VideosInstructivosPageModule)
  },
  {
    path: 'comprar-marca',
    loadChildren: () => import('./comprar-marca/comprar-marca.module').then( m => m.ComprarMarcaPageModule)
  }

];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {}

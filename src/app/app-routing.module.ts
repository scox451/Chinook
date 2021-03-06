import { NgModule } from '@angular/core';
import { NoPreloading, RouterModule, Routes } from '@angular/router';

// import { UserPermissionGuard } from '@app/core/guards/user-permission.guard'

// import { RoleType } from '@shared/models/role-type';

const routes: Routes = [
    { path: '', redirectTo: 'sign-in', pathMatch: 'full' },
    { path: 'tracks',
        loadChildren: () => import('./tracks/tracks.module').then((m) => m.TracksModule)//,
        //canActivate: [UserPermissionGuard],
        //data: {
        //    breadcrumb: { label: 'Users' },
        //    roles: `${RoleType.Admin}` }
    },  
    { 
      path: 'sign-in',
      loadChildren: () => import('./sign-in/sign-in.module').then((m) => m.SignInModule)//,
    },  
    { 
      path: 'home',
      loadChildren: () => import('./home/home.module').then((m) => m.HomeModule)//,
    },  
    { 
      path: 'playlists',
      loadChildren: () => import('./playlist/playlist.module').then((m) => m.PlaylistModule)//,
    },  
    { 
      path: 'mat-demo',
      loadChildren: () => import('./material-demo/material-demo.module').then((m) => m.MaterialDemoModule)//,
    },  
    {
      path: '**',
      redirectTo: '/playlists'
    }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, {
      onSameUrlNavigation: `reload`,
      enableTracing: false,
      preloadingStrategy: NoPreloading,
      relativeLinkResolution: 'legacy'
      })
    ],
  exports: [RouterModule]
})
export class AppRoutingModule {}

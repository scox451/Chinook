import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MaterialDemoComponent } from './material-demo.component';

const routes: Routes = [{ path: '', component: MaterialDemoComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MaterialDemoRoutingModule { }

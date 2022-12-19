import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {AddReqComponent} from './components/add-req/add-req.component';
import { AddSkillComponent } from './components/add-skill/add-skill.component';
import { ListReqComponent } from './components/list-req/list-req.component';
import { ListSkillComponent } from './components/list-skill/list-skill.component';
import { NumberComponent } from './components/number/number.component';

const routes: Routes = [
  {
    path:'',
    component:ListReqComponent
  },
   {
     path:'req/add',
     component:AddReqComponent
   },
   {
    path:'skill/list',
    component:ListSkillComponent
   },
   {
    path:'skill/add',
    component:AddSkillComponent

   },
   {
    path:'req-num',
    component:NumberComponent
   },
   
   
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

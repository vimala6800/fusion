import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListReqComponent } from './components/list-req/list-req.component';
import { AddReqComponent } from './components/add-req/add-req.component';
import { ListSkillComponent } from './components/list-skill/list-skill.component';
import { AddSkillComponent } from './components/add-skill/add-skill.component';
import { NumberComponent } from './components/number/number.component';


@NgModule({
  declarations: [
    AppComponent,
    ListReqComponent,
  
    AddReqComponent,
       ListSkillComponent,
       AddSkillComponent,
       NumberComponent,
       
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

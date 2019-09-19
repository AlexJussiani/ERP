import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { IngredienteComponent } from './ingredientes/ingrediente.component';
import { LancheComponent } from './lanche/lanche.component';
import { ClienteComponent } from './cliente/cliente.component'; 
import { IngredienteServico } from '../servicos/ingrediente/ingrediente.servico';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    IngredienteComponent,
    LancheComponent,
    ClienteComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'ingrediente', component: IngredienteComponent },
      { path: 'lanche', component: LancheComponent },
      { path: 'cliente', component: ClienteComponent }
    ])
  ],
  providers: [IngredienteServico],
  bootstrap: [AppComponent]
})
export class AppModule { }

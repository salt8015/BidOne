import { NgModule } from '@angular/core';
import { HomeComponent } from './home.component';
import { HomeRoutingModule } from './home-routing.module';
import { CommonModule } from '@angular/common';
import { HomeService } from './services/home.service';
import { FormsModule } from '@angular/forms';

@NgModule({
    imports: [
        CommonModule,
        HomeRoutingModule,
        FormsModule
    ],
    declarations: [
        HomeComponent
    ],
    providers: [
        HomeService
    ]
})
export class HomeModule { }

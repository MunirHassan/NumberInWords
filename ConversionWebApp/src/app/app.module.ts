import { BrowserModule } from '@angular/platform-browser'; 
import { NgModule } from '@angular/core'; 
 
import { AppComponent } from './app.component'; 
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { NumberInWordsConverterComponent } from './numberinwords-converter/numberinwords-converter.component'; 
import { ConverterService } from './numberinwords-converter.service'; 
import { HttpClientModule, HttpClient } from '@angular/common/http';


@NgModule({ 
    declarations: [ 
        AppComponent, NumberInWordsConverterComponent 
    ], 
    imports: [ 
        BrowserModule, 
        FormsModule, 
        HttpModule,
        ReactiveFormsModule ,
        HttpClientModule        
    ], 
    providers: [ConverterService,HttpClientModule], 
    bootstrap: [AppComponent] 
}) 
export class AppModule {}
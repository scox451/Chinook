import { OverlayContainer } from '@angular/cdk/overlay';
import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
  templateUrl: './app.component.html',
  styleUrls: [ './app.component.scss' ]
})
export class AppComponent  {

  isDarkMode: boolean = false;
  // Your code here
  
  changeMode(): void {
      this.isDarkMode = !this.isDarkMode;
  }

}
 

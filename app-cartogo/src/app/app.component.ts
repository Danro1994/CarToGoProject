import { Component, OnInit } from '@angular/core';

import { Platform } from '@ionic/angular';
import { SplashScreen } from '@ionic-native/splash-screen/ngx';
import { StatusBar } from '@ionic-native/status-bar/ngx';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.scss']
})
export class AppComponent implements OnInit {
  public selectedIndex = 0;
  public appPages = [
    {
      title: 'Home',
      url: '',
      icon: 'home'
    },{
      title: 'Carros nuevos',
      url: '/folder/Inbox',
      icon: 'mail'
    },
    {
      title: 'Carros usados',
      url: 'carro-usado',
      icon: 'car'
    },
    {
      title: 'Concesionarias',
      url: '/folder/Favorites',
      icon: 'heart'
    },
    {
      title: 'Videos instructivos',
      url: '/folder/Archived',
      icon: 'archive'
    },
    {
      title: 'Comprar por Marca',
      url: '/folder/Trash',
      icon: 'trash'
    },
    {
      title: 'Empty',
      url: '/folder/Spam',
      icon: 'warning'
    }
  ];
  public labels = ['Family', 'Friends', 'Notes', 'Work', 'Travel', 'Reminders'];

  constructor(
    private platform: Platform,
    private splashScreen: SplashScreen,
    private statusBar: StatusBar
  ) {
    this.initializeApp();
  }

  initializeApp() {
    this.platform.ready().then(() => {
      this.statusBar.styleDefault();
      this.splashScreen.hide();
    });
  }

  ngOnInit() {
    const path = window.location.pathname.split('folder/')[1];
    if (path !== undefined) {
      this.selectedIndex = this.appPages.findIndex(page => page.title.toLowerCase() === path.toLowerCase());
    }
  }
}

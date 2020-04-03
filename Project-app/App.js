import {createStackNavigator} from 'react-navigation-stack';
import { createAppContainer } from 'react-navigation';

import MainMenu from './assets/MainMenu'
import NameScreen from './assets/NameScreen'
import Game from './assets/Game'
const Navigator= createStackNavigator({
MainMenu:{
  screen: MainMenu
},
NameScreen:{
  screen: NameScreen
},
Game:{
  screen: Game
}

})
const App=createAppContainer(Navigator);
export default App
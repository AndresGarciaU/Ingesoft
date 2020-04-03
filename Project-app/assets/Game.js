import React,{ Component }  from 'react';
import {Text, View, StyleSheet} from 'react-native';
import {GameEngine} from 'react-native-game-engine';//game engine
import Matter from 'matter-js'//physics engine
import Constants from './Constants';
import Ship from './Ship';
export default class Game extends React.Component{
    constructor(props){
        super(props);
        this.GameEngine=null;
        this.entities=this.setUpWorld

    }
    setUpWorld = () => {
         let engine =Matter.Engine.create({enableSleeping:false});
         let world =engine.world;

         let ship = Matter.Bodies.rectangle(Constants.MAX_WIDTH/4,Constants.MAX_HEIGHT/20,50,50);
          Matter.world.add(world,[ship]);
          return{
              physics:{engine:engine,world:world},
              Ship:{body:Ship,size:[50,50],color:'red',renderer:Ship}
            }
    }
    
    render(){
        return(
            <View>
               <GameEngine
               ref={(ref)=>{this.GameEngine =ref;}}
               style={styles.gameContainer}
               entities={this.entities}
               /> 
                </View>
        );
    }
}

const styles=StyleSheet.create({
 container:{
     flex:1,
     backgroundColor:'black'
 }
});
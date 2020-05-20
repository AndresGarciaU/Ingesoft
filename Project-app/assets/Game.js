import React,{ Component }  from 'react';
import { View, StyleSheet, StatusBar,body} from 'react-native';
import {GameEngine} from 'react-native-game-engine';//game engine
import Matter from 'matter-js'//physics engine
import Constants from './Constants';
import Ship from './Ship';
import Physics from './Physics'
export default class App extends Component {
    constructor(props){
        super(props);

        this.state = {
            running: true
        };

        this.gameEngine = null;

        this.entities = this.setupWorld();
    }

    setupWorld = () => {
        let engine = Matter.Engine.create({ enableSleeping: false });
        let world = engine.world;

        let Ship = Matter.Bodies.rectangle( Constants.MAX_WIDTH / 4, Constants.MAX_HEIGHT / 2);

        Matter.World.add(world, [Ship]);


        return {
            physics: { engine: engine, world: world },
            Ship: { body:Ship,size: [50, 50], color: 'red', renderer: Ship},
        }
    }


    render() {
        return (
            <View style={styles.container}>
                <GameEngine
                    ref={(ref) => { this.gameEngine = ref; }}
                    style={styles.gameContainer}
                    running={this.state.running}
                    entities={this.entities}>
                    <StatusBar hidden={false} />
                </GameEngine>
            </View>
        );
    }
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
    },
    gameContainer: {
        position: 'absolute',
        top: 0,
        bottom: 0,
        left: 0,
        right: 0,
    },
});
import { Component } from "react";

class Text extends Component
{
    render()
    {
        return <p>{this.props.text}</p>
    }
}

export class MyDiv extends Component {
    constructor(props) {
        super(props);
        this.state={class:"light"}

        this.change = this.change.bind(this);

    }
    change(ev)
    {
        if(ev.target.value==="light")
        {
            this.setState({class:"dark"});
        }
        else {
            this.setState({class:"light"});
        }
    }
    render()
    {
        return (
            <div className={this.state.class}>
                <div id="topic" >
                    <span>Dark</span> <input type="radio" value="dark" name="theme" id="dark" onChange={this.change}></input>
                    <span>White</span> <input type="radio" value="light" name="theme" id="white" onChange={this.change}></input>
                </div>
                <Text text="If you aren't satisfied with the build tool and configuration choices, you can eject at any time. This command will remove the single build dependency from your project.
                Instead, it will copy all the configuration files and the transitive dependencies (webpack, Babel, ESLint, etc) right into your project so you have full control over them. All of the commands except eject will still work, but they will point to the copied scripts so you can tweak them. At this point you're on your own.
                You don't have to ever use eject. The curated feature set is suitable for small and middle deployments, and you shouldn't feel obligated to use this feature. However we understand that this tool wouldn't be useful if you couldn't customize it when you are ready for it."></Text>

            </div>
        )
    }
}
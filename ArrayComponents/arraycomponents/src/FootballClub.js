import './FootballClub.css'

export function FootballClubInfo(props)
{
    return (
        <div id="info">
            <p>Название клуба: <b>{props.nameClub}</b></p>
            <p>Город: <b>{props.city}</b></p>
            <p>Дата основания клуба: <b>{props.date}</b></p>
            <p>Побед в этом году: <b>{props.countWins}</b></p>
            <p id="pImageClub">Герб клуба: </p>
            <img src={props.image} alt=""></img>
        </div>
    )
}

function ViewPhoto(props)
{
    return (
    <div id="photosReward">{props.photos.map(photo => (
        <img src={photo} alt=""></img>
    ))}</div>
    )
}
export function FootballClubRewards(props)
{
    return(
    <div id="rewards">
        <p id="pRewards">Достижения</p>
        {props.rewards.map(reward => (
            <div>
                <p id='rewardDescription'>{reward.description}</p>
                <p>В каком году: <b>{reward.date}</b></p>
                <p>Фото из достижения: </p>
                <ViewPhoto photos={reward.photos}></ViewPhoto>
            </div>
            )
        )}
    </div>
    )
}

export function FootballClubTeam(props)
{
    return (
    <div id="team">
        <p>Игроки</p>
        {props.team.map(player => (     
            <div>
                <img src={player.photo} alt=""></img>
                <p>Имя: <b>{player.name}</b></p>
                <p>Фамилия: <b>{player.surname}</b></p>
                <p>Забитых голов: <b>{player.countGoals}</b></p>
                <p>Позиция: <b>{player.position}</b></p>
                <p>Описание: <b>{player.description}</b></p>
            </div>
        ))}
    </div>
    )
} 
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace fountainGame;

public class fountainGame : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public fountainGame()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize() //Not always needed
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent() //You're allowed to load and unload content as your game runs. e.g. different rooms
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime) //This method is called over and over in the game loop, along with Update.
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}


//

/* MCGB EDITOR
----------------------------
#1: add game assets
----------------------------
The answer to this question is usually "Copy the file to the directory." 
If you are working on a project with others or using version control of any sort, 
you will want to have all of your content files together. 

That ensures the whole project is self-contained and will work even if you move between computers or if a teammate tries to use it. 
The option to link can work fine as well, but requires some extra strategizing to ensure the content files will always be where the link thinks it is at.

(still in the MCGB editor)
That can be done easily by pushing Build > Build from the menu. When you do this, you will see it process all of your files and report if it was successful and, if not, why it failed. 
The MGCB Editor does a better job at showing you the errors than Visual Studio does, so it is good to see if it is working before going back to Visual Studio.

------------------------------------
(AFTER MCGB BUILD SUCCEEDS)
#2: load the now-ready game assets into the game
------------------------------------
The content pipeline has the responsibility of turning a content file into a game-ready asset. 
When this process finishes, you're left with a game asset stored in a file that you can ship as a part of your game. But the journey isn't done there.
!! We still need to load the game-ready asset into the game itself. 
*/

using System;
using NUnit.Framework;

namespace GameOfLifeKata.Tests
{
    [TestFixture]
    public class GameOfLifeTests
    {
        // We could of taken smaller steps based of the instructions
        [Test]
        public void Execute_GivenInitialGameStateIsBlockShouldReturnBlock()
        {
            int[,] initialGameState = new int[, ]{{0,0,0,0},{0,1,1,0},{0,1,1,0},{0,0,0,0}};
            var sut = new GameOfLife();
            var result =sut.Execute(initialGameState);
            var expected = new int[,]
                {{0, 0, 0, 0, 0}, {0, 0, 1, 0, 0}, {0, 1, 0, 1, 0}, {0, 1, 0, 1, 0}, {0, 0, 1, 0, 0}, {0, 0, 0, 0, 0}};
            Assert.AreEqual(initialGameState,result);
        }
        
        [Test]
        public void Execute_GivenInitialGameStateIsBeehiveShouldReturnBeehive()
        {
            int[,] initialGameState = new int[,]
                {{0, 0, 0, 0, 0}, {0, 0, 1, 0, 0}, {0, 1, 0, 1, 0}, {0, 1, 0, 1, 0}, {0, 0, 1, 0, 0}, {0, 0, 0, 0, 0}};;
            var sut = new GameOfLife();
            var result =sut.Execute(initialGameState);
            Assert.AreEqual(initialGameState,result);
        }
        
        [Test]
        public void Execute_GivenInitialGameStateHasLiveCellWithFewerThanTwoNeighbours_ThenCellShouldDie()
        {
            int[,]  initialGameState = new int[, ]{{0,0,0,0},{0,1,1,0},{0,0,0,0},{0,0,0,0}};
            var sut = new GameOfLife();
            var result =sut.Execute(initialGameState);
            var expected  = new int[, ]{{0,0,0,0},{0,0,0,0},{0,0,0,0},{0,0,0,0}};
            Assert.AreEqual(expected,result);
        }
        
        [Test]
        public void Execute_GivenInitialGameStateHasLiveCellWithTwoNeighbours_ThenCellShouldLive()
        {
            int[,]  initialGameState = new int[, ]{{0,0,0,0},{0,1,1,0},{0,1,0,0},{0,0,0,0}};
            var sut = new GameOfLife();
            var result =sut.Execute(initialGameState);
            Assert.AreEqual(initialGameState,result);
        }
        
        [Test]
        public void Execute_GivenInitialGameStateHasLiveCellWithThreeNeighbours_ThenCellShouldLive()
        {
            int[,]  initialGameState = new int[, ]{{0,0,0,0},{0,1,1,0},{0,1,1,0},{0,0,0,0}};
            var sut = new GameOfLife();
            var result =sut.Execute(initialGameState);
            Assert.AreEqual(initialGameState,result);
        }
        
        [Test]
        public void Execute_GivenInitialGameStateHasLiveCellWithMoreThanThreeNeighbours_ThenCellShouldDie()
        {
            int[,]  initialGameState = new int[, ]{{0,0,0,0},{1,1,1,0},{0,1,0,0},{0,0,0,0}};
            var sut = new GameOfLife();
            var result =sut.Execute(initialGameState);
            var expected = new int[, ]{{0,0,0,0},{1,0,1,0},{0,1,0,0},{0,0,0,0}};
            Assert.AreEqual(initialGameState,result);
        }
        
        [Test]
        public void Execute_GivenInitialGameStateHasDeadCellWithMoreThanThreeNeighbours_ThenCellShouldBecomeLive()
        {
            int[,]  initialGameState = new int[, ]{{0,0,0,0},{1,0,1,0},{0,1,0,0},{0,0,0,0}};
            var sut = new GameOfLife();
            var result =sut.Execute(initialGameState);
            var expected = new int[, ]{{0,0,0,0},{0,1,0,0},{0,0,0,0},{0,0,0,0}};
            Assert.AreEqual(initialGameState,result);
        }
    }
}
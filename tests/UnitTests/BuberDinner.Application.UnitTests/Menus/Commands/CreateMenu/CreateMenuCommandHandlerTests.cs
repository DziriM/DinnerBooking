using BuberDinner.Application.Common.Interfaces.Persistence;
using BuberDinner.Application.Menus.Commands.CreateMenu;
using BuberDinner.Application.UnitTests.Menus.Commands.TestUtils;
using BuberDinner.Application.UnitTests.TestUtils.Menus.Extensions;
using BuberDinner.Domain.MenuAggregate;
using ErrorOr;
using FluentAssertions;
using Moq;

namespace BuberDinner.Application.UnitTests.Menus.Commands.CreateMenu;

public class CreateMenuCommandHandlerTests
{
    private readonly CreateMenuCommandHandler _handler;
    private readonly Mock<IMenuRepository> _mockMenuRepository;

    public CreateMenuCommandHandlerTests(CreateMenuCommandHandler handler, Mock<IMenuRepository> mockMenuRepository)
    {
        _handler = handler;
        _mockMenuRepository = mockMenuRepository;
    }

    [Theory]
    [MemberData((nameof(ValidCreateMenuCommands)))]
    public async Task HandleCreateMenuCommand_WhenMenuIsValid_ShouldCreateAndReturnMenu(CreateMenuCommand createMenuCommand)
    {
        // Act
        ErrorOr<Menu> result = await _handler.Handle(createMenuCommand, default);

        // Assert
        result.IsError.Should().BeFalse();
        result.Value.ValidateCreatedFrom(createMenuCommand);
        _mockMenuRepository.Verify(m => m.Add(result.Value), Times.Once);
    }

    public static IEnumerable<object[]> ValidCreateMenuCommands()
    {
        yield return new[] { CreateMenuCommandUtils.CreateCommand() };
        
        yield return new[]
        {
            CreateMenuCommandUtils.CreateCommand(sections: CreateMenuCommandUtils.CreateSectionsCommand(sectionCount: 3))
        };
        
        yield return new[]
        {
            CreateMenuCommandUtils.CreateCommand(sections: CreateMenuCommandUtils.CreateSectionsCommand(
                sectionCount: 3,
                items: CreateMenuCommandUtils.CreateItemsCommand(itemCount: 3))),
        };
    }
}


// Rules for naming a Test
/*
   T1 : SUT (System Under Test) - Logical component we're testing
   T2 : Scenario - What we're testing
   T3 : Expected outcome - What we excpect the logical component to do

    // THE WINNER IS => Best naming practice !!!
    public void HandleCreateMenuCommand_WhenMenuIsValid_ShouldCreateAndReturnMenu() { }

    // Bad Practice : It means nothing to follow a "happy flow"
    public void Test_HappyFlow() { }

    // OK but : It lacks the structure to have consistent/uniform naming in a team envrironment
    public void Creating_A_Menu_Creates_And_Returns_Menu() { }

    // As good as the first except that it add some cognitive load
    public void Test_CreateMenuCommandHandler_HandleValid_ReturnsMenu() { }

*/
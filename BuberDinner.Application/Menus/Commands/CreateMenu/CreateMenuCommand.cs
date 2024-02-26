using BuberDinner.Contracts.Menus;
using BuberDinner.Domain.MenuAggregate;
using MediatR;
using ErrorOr;

namespace BuberDinner.Application.Menus.Commands.CreateMenu;

public record CreateMenuCommand(
    Guid HostId,
    string Name,
    string Description,
    List<CreateMenuSectionCommand> Sections) : IRequest<ErrorOr<Menu>>;

public record CreateMenuSectionCommand(
    string Name,
    string Description,
    List<CreateMenuItemCommand> Items);

public record CreateMenuItemCommand(
    string Name,
    string Description);

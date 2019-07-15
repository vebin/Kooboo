import { BaseEvent } from "./BaseEvent";

export enum MenuActions {
  close,
  expand,
  edit,
  copy,
  delete,
  editImage,
  editLink,
  enterLink,
  editHtmlBlock,
  editRepeat,
  editMenu,
  editStyle,
  copyRepeat,
  deleteRepeat,
  replaceToImg,
  replaceToText
}

export class FloatMenuClickEvent extends BaseEvent<MenuActions> {}

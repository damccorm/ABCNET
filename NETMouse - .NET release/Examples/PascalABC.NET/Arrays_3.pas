﻿{$reference ABCNET.dll}
uses ABCNET.Utils;
uses ABCNET.Extensions;
begin
  Arr.ReadInteger(Base.ReadInteger('N:'), 'Элемент {0}-ый:').Sum().Println();
  Base.ReadChar();
end.
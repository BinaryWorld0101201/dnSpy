﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using dnSpy.Contracts.Command;

namespace dnSpy.Files.Tabs.DocViewer {
	static class FileTabCommandConstants {
		public static readonly Guid FileTabGroup = new Guid("76CB650C-61E4-49E7-B820-5DE5476CE29D");
		public const double CMDINFO_ORDER_FILETAB = CommandConstants.CMDINFO_ORDER_TEXT_EDITOR - 100;
		public const double CMDTARGETFILTER_ORDER_FILETAB = CommandConstants.CMDTARGETFILTER_ORDER_TEXT_EDITOR - 100;
	}
}
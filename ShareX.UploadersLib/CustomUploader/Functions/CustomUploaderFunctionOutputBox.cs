﻿#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (c) 2007-2025 ShareX Team

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using ShareX.HelpersLib;

namespace ShareX.UploadersLib
{
    // Example: {outputbox:text}
    // Example: {outputbox:title|text}
    internal class CustomUploaderFunctionOutputBox : CustomUploaderFunction
    {
        public override string Name { get; } = "outputbox";

        public override int MinParameterCount { get; } = 1;

        public override string Call(ShareXCustomUploaderSyntaxParser parser, string[] parameters)
        {
            string text, title = null;

            if (parameters.Length > 1)
            {
                title = parameters[0];
                text = parameters[1];
            }
            else
            {
                text = parameters[0];
            }

            if (!string.IsNullOrEmpty(text))
            {
                if (string.IsNullOrEmpty(title))
                {
                    title = "Output";
                }

                OutputBox.Show(text, title);
            }

            return null;
        }
    }
}
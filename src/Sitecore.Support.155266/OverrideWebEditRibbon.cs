using Sitecore.ExperienceEditor.Pipelines.GetExperienceEditorRibbon;
using Sitecore.Support.ExperienceEditor.Speak.Ribbon.PageExtender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.ExperienceEditor.Speak.Ribbon.Pipelines.GetExperienceEditorRibbon
{ 
    public class OverrideWebEditRibbon : WebEditStateProcessor
    {
        public override void AddControl(GetExperienceEditorRibbonArgs args)
        {
            throw new NotImplementedException();
        }

        public new void Process(GetExperienceEditorRibbonArgs args)
        {
            var c = args.Control as RibbonWebControl;
            if (c != null)
            {
                args.Control = new RibbonWebControl
                {
                    State = c.State
                };
            }
        }
    }
}
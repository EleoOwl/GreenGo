using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenGo.DB.API.Models.Validation
{
    public class PanelModelValidator : ModelValidator<PanelModel>
    {
        public override bool Validate(PanelModel model)
        {
            return true;
            /*
            var baseResult = base.Validate(model);
            if (baseResult.IsFailed)
            {
                return baseResult;
            }

            var validationResults = new List<Result>
            {
                ValidateIfGuidIsEmpty(model.Id, "License Id")
            };

            if (AssignmentsAreMissing(model))
            {
                validationResults.Add(Result.Fail(InvalidRequestMessage, MissingAssignmentsMessage));
                return validationResults.Flatten(InvalidRequestMessage, ErrorStatus.ValidationFailed);
            }

            if (AssignmentsAreMixed(model))
            {
                validationResults.Add(Result.Fail(MixedAssignmentsMessage));
                return validationResults.Flatten(InvalidRequestMessage, ErrorStatus.ValidationFailed);
            }

            if (HasDuplicateIds(model))
            {
                validationResults.Add(Result.Fail(DuplicateAssignmentsMessage));
                return validationResults.Flatten(InvalidRequestMessage, ErrorStatus.ValidationFailed);
            }

            foreach (var linkGroup in model.LinkGroups ?? Enumerable.Empty<ClientAssignmentModel>())
            {
                validationResults.Add(ValidateIfGuidIsEmpty(linkGroup.Id, "Link group Id"));
            }

            foreach (var zone in model.Zones ?? Enumerable.Empty<ClientAssignmentModel>())
            {
                validationResults.Add(ValidateIfGuidIsEmpty(zone.Id, "Zone Id"));
            }

            return validationResults.Flatten(InvalidRequestMessage, ErrorStatus.ValidationFailed);
        */
        }

    }
}

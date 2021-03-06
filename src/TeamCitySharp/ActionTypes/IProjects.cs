using System.Collections.Generic;
using TeamCitySharp.DomainEntities;
using TeamCitySharp.Locators;

namespace TeamCitySharp.ActionTypes
{
  public interface IProjects
  {
    List<Project> All();
    Projects GetFields(string fields);
    Project ByName(string projectLocatorName);
    Project ById(string projectLocatorId);
    Project Details(Project project);
    Project Create(string projectName);
    Project Create(string projectName, string sourceId, string projectId = "");
    Project Move(string projectId, string destinationId);
    Project Copy(string sourceProjectId, string newProjectName, string newProjectId, string parentProjectId = "");
    string GenerateID(string projectName);
    void Delete(string projectName);
    void DeleteById(string projectId);
    void DeleteProjectParameter(string projectName, string parameterName);
    void SetProjectParameter(string projectName, string settingName, string settingValue);
    bool ModifParameters(string projectId, string mainprojectbranch, string variablePath);
    bool ModifSettings(string projectId, string description, string fullProjectName);
    Branches GetBranchesByBuildProjectId(string projectId, BranchLocator locator = null);
    ProjectFeatures GetProjectFeatures(string projectLocatorId);
    ProjectFeature GetProjectFeatureByProjectFeature(string projectLocatorId, string projectFeatureId);
    ProjectFeature CreateProjectFeature(string projectId, ProjectFeature projectFeature);
    void DeleteProjectFeature(string projectId, string projectFeatureId);
  }
}
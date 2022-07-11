﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MarsQA.SpecFlow
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Seller Add Profile Details")]
    public partial class SellerAddProfileDetailsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Profile.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SpecFlow", "Seller Add Profile Details", "\tAs a Seller\r\nI want the feature to add my Profile Details\r\nSo that\r\nThe people s" +
                    "eeking for some skills can look into my details.", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A1 Login to mars portal with valid credentials")]
        [NUnit.Framework.CategoryAttribute("Login")]
        public void A1LoginToMarsPortalWithValidCredentials()
        {
            string[] tagsOfScenario = new string[] {
                    "Login"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A1 Login to mars portal with valid credentials", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
    testRunner.Given("I open the  browser and Login with valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.Then("I logged into poratl Successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("B1 Add personal details")]
        [NUnit.Framework.CategoryAttribute("PersonalDetails")]
        public void B1AddPersonalDetails()
        {
            string[] tagsOfScenario = new string[] {
                    "PersonalDetails"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("B1 Add personal details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 15
    testRunner.Given("I logged into Mars portal successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 16
 testRunner.When("I input my first name and last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.And("I click Availability, Hours, Earn Target and input Descriptioon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.Then("The profile page details should be added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("B2 Update personal details")]
        [NUnit.Framework.CategoryAttribute("PersonalDetails")]
        public void B2UpdatePersonalDetails()
        {
            string[] tagsOfScenario = new string[] {
                    "PersonalDetails"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("B2 Update personal details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 21
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 22
    testRunner.Given("I logged into Mars portal successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 23
 testRunner.When("I Update my first name and last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.And("I update Availability, Hours, Earn Target and Descriptioon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.Then("The profile page details should be updated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("B3 Add personal details")]
        [NUnit.Framework.CategoryAttribute("PersonalDetails")]
        public void B3AddPersonalDetails()
        {
            string[] tagsOfScenario = new string[] {
                    "PersonalDetails"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("B3 Add personal details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 28
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 29
    testRunner.Given("I logged into Mars portal successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 30
 testRunner.When("I delete my first name and last name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.And("I delete Descriptioon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.Then("The profile page details should be deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("C1 create language record with details")]
        [NUnit.Framework.CategoryAttribute("Language")]
        [NUnit.Framework.TestCaseAttribute("English", null)]
        [NUnit.Framework.TestCaseAttribute("Telugu", null)]
        public void C1CreateLanguageRecordWithDetails(string language, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Language"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("language", language);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("C1 create language record with details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 35
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 36
 testRunner.Given("I logged into Mars portal successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 37
 testRunner.When("I navigate to language module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.And(string.Format("I add new \'{0}\' records on lauguange module", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.Then(string.Format("the \'{0}\' records should be added in language module successfully", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("C2 edit language record with details")]
        [NUnit.Framework.CategoryAttribute("Language")]
        [NUnit.Framework.TestCaseAttribute("French", null)]
        [NUnit.Framework.TestCaseAttribute("Hindi", null)]
        public void C2EditLanguageRecordWithDetails(string language, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Language"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Language", language);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("C2 edit language record with details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 49
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 50
 testRunner.Given("I logged into Mars portal successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 51
 testRunner.When("I navigate to language module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.And(string.Format("I update \'{0}\'on existing language record", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.Then(string.Format("the language record should have updated \'{0}\'", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("delete existing language record")]
        [NUnit.Framework.CategoryAttribute("Language")]
        public void DeleteExistingLanguageRecord()
        {
            string[] tagsOfScenario = new string[] {
                    "Language"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("delete existing language record", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 59
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 60
 testRunner.Given("I logged into Mars portal successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 61
 testRunner.When("I navigate to language module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.And("I delete existing language record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.Then("the language record should disappear from the language module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("D1 Create Education record with the details")]
        [NUnit.Framework.CategoryAttribute("Education")]
        [NUnit.Framework.TestCaseAttribute("Annamacharya University", "Bachelor", null)]
        [NUnit.Framework.TestCaseAttribute("Auckland University", "Master", null)]
        public void D1CreateEducationRecordWithTheDetails(string universityName, string degree, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Education"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UniversityName", universityName);
            argumentsOfScenario.Add("Degree", degree);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("D1 Create Education record with the details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 66
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 67
 testRunner.Given("I logged into Mars portal successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 68
 testRunner.When("I navigate to Education module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.And(string.Format("I add new education record with \'{0}\' and \'{1}\'", universityName, degree), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.Then(string.Format("the education record should be added successfully with correct \'{0}\' and \'{1}\'", universityName, degree), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("D2 edit education record with details")]
        [NUnit.Framework.CategoryAttribute("Education")]
        [NUnit.Framework.TestCaseAttribute("The University of Auckland", "Postgraduate", null)]
        [NUnit.Framework.TestCaseAttribute("The University of melbourne", "Master", null)]
        public void D2EditEducationRecordWithDetails(string universityName, string degree, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Education"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UniversityName", universityName);
            argumentsOfScenario.Add("Degree", degree);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("D2 edit education record with details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 77
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 78
 testRunner.Given("I logged into Mars portal successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 79
 testRunner.When("I navigate to education Module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.And(string.Format("I update \'{0}\' and \'{1}\' on existing education record", universityName, degree), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
 testRunner.Then(string.Format("the education record should have updated \'{0}\' and \'{1}\'", universityName, degree), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("D3 delete existing education record")]
        [NUnit.Framework.CategoryAttribute("Education")]
        public void D3DeleteExistingEducationRecord()
        {
            string[] tagsOfScenario = new string[] {
                    "Education"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("D3 delete existing education record", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 87
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 88
 testRunner.Given("I logged into Mars portal successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 89
 testRunner.When("I navigate to education Module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
 testRunner.And("I delete existing education record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
 testRunner.Then("the education record should delete from the education module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("E1 create certification record with details")]
        [NUnit.Framework.CategoryAttribute("Certifications")]
        [NUnit.Framework.TestCaseAttribute("Best Programmer", "Industry Connect", null)]
        [NUnit.Framework.TestCaseAttribute("Best lecturers", "Lincoln University", null)]
        public void E1CreateCertificationRecordWithDetails(string certificationName, string certificatedFrom, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Certifications"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("CertificationName", certificationName);
            argumentsOfScenario.Add("CertificatedFrom", certificatedFrom);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("E1 create certification record with details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 94
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 95
 testRunner.Given("I logged into Mars portal successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 96
 testRunner.When("I navigate to certification Module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 97
 testRunner.And(string.Format("I add new certification record with \'{0}\' and \'{1}\'", certificationName, certificatedFrom), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.Then(string.Format("the certification record should be added successfully with correct \'{0}\' and \'{1}" +
                            "\'", certificationName, certificatedFrom), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("E2 edit certification record with details")]
        [NUnit.Framework.CategoryAttribute("Certifications")]
        [NUnit.Framework.TestCaseAttribute("Best Tester", "MVP Studio", null)]
        [NUnit.Framework.TestCaseAttribute("Best Tutors", "University of Canterbury", null)]
        public void E2EditCertificationRecordWithDetails(string certificationName, string certificatedFrom, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Certifications"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("CertificationName", certificationName);
            argumentsOfScenario.Add("CertificatedFrom", certificatedFrom);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("E2 edit certification record with details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 104
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 105
 testRunner.Given("I logged into Mars portal successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 106
 testRunner.When("I navigate to certification Module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 107
 testRunner.And(string.Format("I update \'{0}\' and \'{1}\' on existing certification record", certificationName, certificatedFrom), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 108
 testRunner.Then(string.Format("the certification record should have updated \'{0}\' and \'{1}\'", certificationName, certificatedFrom), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("E3 delete existing certification record")]
        [NUnit.Framework.CategoryAttribute("Certifications")]
        public void E3DeleteExistingCertificationRecord()
        {
            string[] tagsOfScenario = new string[] {
                    "Certifications"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("E3 delete existing certification record", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 114
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 115
 testRunner.Given("I logged into Mars portal successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 116
 testRunner.When("I navigate to certification Module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 117
 testRunner.And("I delete existing certification record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 118
 testRunner.Then("the certification record should disappear from the certification module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("F1 create skill record with details")]
        [NUnit.Framework.CategoryAttribute("Skill")]
        [NUnit.Framework.TestCaseAttribute("Programming", null)]
        [NUnit.Framework.TestCaseAttribute("Writing", null)]
        public void F1CreateSkillRecordWithDetails(string skill, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Skill"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("skill", skill);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("F1 create skill record with details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 120
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 121
 testRunner.Given("I logged into Mars portal successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 122
 testRunner.When("I navigate to skills Module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 123
 testRunner.And(string.Format("I add new \'{0}\' record in skill module", skill), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 124
 testRunner.Then(string.Format("the \'{0}\' record should be added successfully in skill module", skill), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("F2 edit skill record with details")]
        [NUnit.Framework.CategoryAttribute("Skill")]
        [NUnit.Framework.TestCaseAttribute("Automation Testing", null)]
        [NUnit.Framework.TestCaseAttribute("Swimming", null)]
        public void F2EditSkillRecordWithDetails(string skill, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Skill"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("skill", skill);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("F2 edit skill record with details", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 130
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 131
 testRunner.Given("I logged into Mars portal successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 132
 testRunner.When("I navigate to skills Module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 133
 testRunner.And(string.Format("I update \'{0}\'on existing skill record", skill), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 134
 testRunner.Then(string.Format("the skill record should have updated \'{0}\'", skill), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("F3 delete existing skill record")]
        [NUnit.Framework.CategoryAttribute("Skill")]
        public void F3DeleteExistingSkillRecord()
        {
            string[] tagsOfScenario = new string[] {
                    "Skill"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("F3 delete existing skill record", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 140
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 141
 testRunner.Given("I logged into Mars portal successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 142
 testRunner.When("I navigate to skills Module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 143
 testRunner.And("I delete existing skill record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 144
 testRunner.Then("the skill record should disappear from the skills module", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

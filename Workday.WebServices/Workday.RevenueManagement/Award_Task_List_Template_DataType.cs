using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Task_List_Template_DataType : INotifyPropertyChanged
	{
		private string award_Task_List_Template_IDField;

		private string template_NameField;

		private SponsorObjectType sponsor_ReferenceField;

		private Sponsor_Award_TypeObjectType award_Type_ReferenceField;

		private Award_Purpose_CodeObjectType[] award_Purpose_Code_ReferenceField;

		private Award_Posting_Interval_GroupObjectType award_Posting_Interval_Group_ReferenceField;

		private bool closeout_TemplateField;

		private bool closeout_TemplateFieldSpecified;

		private Award_Task_Template_DataType[] award_Task_Template_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Award_Task_List_Template_ID
		{
			get
			{
				return this.award_Task_List_Template_IDField;
			}
			set
			{
				this.award_Task_List_Template_IDField = value;
				this.RaisePropertyChanged("Award_Task_List_Template_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Template_Name
		{
			get
			{
				return this.template_NameField;
			}
			set
			{
				this.template_NameField = value;
				this.RaisePropertyChanged("Template_Name");
			}
		}

		[XmlElement(Order = 2)]
		public SponsorObjectType Sponsor_Reference
		{
			get
			{
				return this.sponsor_ReferenceField;
			}
			set
			{
				this.sponsor_ReferenceField = value;
				this.RaisePropertyChanged("Sponsor_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Sponsor_Award_TypeObjectType Award_Type_Reference
		{
			get
			{
				return this.award_Type_ReferenceField;
			}
			set
			{
				this.award_Type_ReferenceField = value;
				this.RaisePropertyChanged("Award_Type_Reference");
			}
		}

		[XmlElement("Award_Purpose_Code_Reference", Order = 4)]
		public Award_Purpose_CodeObjectType[] Award_Purpose_Code_Reference
		{
			get
			{
				return this.award_Purpose_Code_ReferenceField;
			}
			set
			{
				this.award_Purpose_Code_ReferenceField = value;
				this.RaisePropertyChanged("Award_Purpose_Code_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Award_Posting_Interval_GroupObjectType Award_Posting_Interval_Group_Reference
		{
			get
			{
				return this.award_Posting_Interval_Group_ReferenceField;
			}
			set
			{
				this.award_Posting_Interval_Group_ReferenceField = value;
				this.RaisePropertyChanged("Award_Posting_Interval_Group_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public bool Closeout_Template
		{
			get
			{
				return this.closeout_TemplateField;
			}
			set
			{
				this.closeout_TemplateField = value;
				this.RaisePropertyChanged("Closeout_Template");
			}
		}

		[XmlIgnore]
		public bool Closeout_TemplateSpecified
		{
			get
			{
				return this.closeout_TemplateFieldSpecified;
			}
			set
			{
				this.closeout_TemplateFieldSpecified = value;
				this.RaisePropertyChanged("Closeout_TemplateSpecified");
			}
		}

		[XmlElement("Award_Task_Template_Data", Order = 7)]
		public Award_Task_Template_DataType[] Award_Task_Template_Data
		{
			get
			{
				return this.award_Task_Template_DataField;
			}
			set
			{
				this.award_Task_Template_DataField = value;
				this.RaisePropertyChanged("Award_Task_Template_Data");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}

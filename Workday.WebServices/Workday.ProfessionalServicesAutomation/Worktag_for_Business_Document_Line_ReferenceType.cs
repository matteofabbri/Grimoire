using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ProfessionalServicesAutomation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worktag_for_Business_Document_Line_ReferenceType : INotifyPropertyChanged
	{
		private Cost_Center_ReferenceType[] cost_Center_ReferenceField;

		private Region_ReferenceType[] region_ReferenceField;

		private Project_ReferenceType project_ReferenceField;

		private Custom_Worktag_01_ReferenceType custom_Worktag_1_ReferenceField;

		private Custom_Worktag_02_ReferenceType custom_Worktag_2_ReferenceField;

		private Custom_Worktag_03_ReferenceType custom_Worktag_3_ReferenceField;

		private Custom_Worktag_04_ReferenceType custom_Worktag_4_ReferenceField;

		private Custom_Worktag_05_ReferenceType custom_Worktag_5_ReferenceField;

		private Prospect_ReferenceType prospect_ReferenceField;

		private Opportunity_ReferenceType opportunity_ReferenceField;

		private Customer_ReferenceType customer_ReferenceField;

		private Customer_Request_ID_for_Customer_ReferenceType customer_Request_ID_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Cost_Center_Reference", Order = 0)]
		public Cost_Center_ReferenceType[] Cost_Center_Reference
		{
			get
			{
				return this.cost_Center_ReferenceField;
			}
			set
			{
				this.cost_Center_ReferenceField = value;
				this.RaisePropertyChanged("Cost_Center_Reference");
			}
		}

		[XmlElement("Region_Reference", Order = 1)]
		public Region_ReferenceType[] Region_Reference
		{
			get
			{
				return this.region_ReferenceField;
			}
			set
			{
				this.region_ReferenceField = value;
				this.RaisePropertyChanged("Region_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Project_ReferenceType Project_Reference
		{
			get
			{
				return this.project_ReferenceField;
			}
			set
			{
				this.project_ReferenceField = value;
				this.RaisePropertyChanged("Project_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Custom_Worktag_01_ReferenceType Custom_Worktag_1_Reference
		{
			get
			{
				return this.custom_Worktag_1_ReferenceField;
			}
			set
			{
				this.custom_Worktag_1_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_1_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Custom_Worktag_02_ReferenceType Custom_Worktag_2_Reference
		{
			get
			{
				return this.custom_Worktag_2_ReferenceField;
			}
			set
			{
				this.custom_Worktag_2_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_2_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Custom_Worktag_03_ReferenceType Custom_Worktag_3_Reference
		{
			get
			{
				return this.custom_Worktag_3_ReferenceField;
			}
			set
			{
				this.custom_Worktag_3_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_3_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Custom_Worktag_04_ReferenceType Custom_Worktag_4_Reference
		{
			get
			{
				return this.custom_Worktag_4_ReferenceField;
			}
			set
			{
				this.custom_Worktag_4_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_4_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Custom_Worktag_05_ReferenceType Custom_Worktag_5_Reference
		{
			get
			{
				return this.custom_Worktag_5_ReferenceField;
			}
			set
			{
				this.custom_Worktag_5_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_5_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Prospect_ReferenceType Prospect_Reference
		{
			get
			{
				return this.prospect_ReferenceField;
			}
			set
			{
				this.prospect_ReferenceField = value;
				this.RaisePropertyChanged("Prospect_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Opportunity_ReferenceType Opportunity_Reference
		{
			get
			{
				return this.opportunity_ReferenceField;
			}
			set
			{
				this.opportunity_ReferenceField = value;
				this.RaisePropertyChanged("Opportunity_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Customer_ReferenceType Customer_Reference
		{
			get
			{
				return this.customer_ReferenceField;
			}
			set
			{
				this.customer_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Customer_Request_ID_for_Customer_ReferenceType Customer_Request_ID_Reference
		{
			get
			{
				return this.customer_Request_ID_ReferenceField;
			}
			set
			{
				this.customer_Request_ID_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Request_ID_Reference");
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

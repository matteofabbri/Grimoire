using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Talent_Assessment_DataType : INotifyPropertyChanged
	{
		private PotentialObjectType potential_ReferenceField;

		private Achievable_LevelObjectType achievable_Level_ReferenceField;

		private RetentionObjectType retention_Risk_ReferenceField;

		private Loss_ImpactObjectType loss_Impact_Risk_ReferenceField;

		private string notesField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public PotentialObjectType Potential_Reference
		{
			get
			{
				return this.potential_ReferenceField;
			}
			set
			{
				this.potential_ReferenceField = value;
				this.RaisePropertyChanged("Potential_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Achievable_LevelObjectType Achievable_Level_Reference
		{
			get
			{
				return this.achievable_Level_ReferenceField;
			}
			set
			{
				this.achievable_Level_ReferenceField = value;
				this.RaisePropertyChanged("Achievable_Level_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public RetentionObjectType Retention_Risk_Reference
		{
			get
			{
				return this.retention_Risk_ReferenceField;
			}
			set
			{
				this.retention_Risk_ReferenceField = value;
				this.RaisePropertyChanged("Retention_Risk_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Loss_ImpactObjectType Loss_Impact_Risk_Reference
		{
			get
			{
				return this.loss_Impact_Risk_ReferenceField;
			}
			set
			{
				this.loss_Impact_Risk_ReferenceField = value;
				this.RaisePropertyChanged("Loss_Impact_Risk_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Notes
		{
			get
			{
				return this.notesField;
			}
			set
			{
				this.notesField = value;
				this.RaisePropertyChanged("Notes");
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

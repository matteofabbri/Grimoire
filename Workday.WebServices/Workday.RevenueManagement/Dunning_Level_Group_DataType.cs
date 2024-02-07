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
	public class Dunning_Level_Group_DataType : INotifyPropertyChanged
	{
		private string dunning_Level_Group_IDField;

		private string nameField;

		private bool by_Risk_ScoreField;

		private bool by_Risk_ScoreFieldSpecified;

		private Dunning_Level_DataType[] dunning_Level_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Dunning_Level_Group_ID
		{
			get
			{
				return this.dunning_Level_Group_IDField;
			}
			set
			{
				this.dunning_Level_Group_IDField = value;
				this.RaisePropertyChanged("Dunning_Level_Group_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool By_Risk_Score
		{
			get
			{
				return this.by_Risk_ScoreField;
			}
			set
			{
				this.by_Risk_ScoreField = value;
				this.RaisePropertyChanged("By_Risk_Score");
			}
		}

		[XmlIgnore]
		public bool By_Risk_ScoreSpecified
		{
			get
			{
				return this.by_Risk_ScoreFieldSpecified;
			}
			set
			{
				this.by_Risk_ScoreFieldSpecified = value;
				this.RaisePropertyChanged("By_Risk_ScoreSpecified");
			}
		}

		[XmlElement("Dunning_Level_Data", Order = 3)]
		public Dunning_Level_DataType[] Dunning_Level_Data
		{
			get
			{
				return this.dunning_Level_DataField;
			}
			set
			{
				this.dunning_Level_DataField = value;
				this.RaisePropertyChanged("Dunning_Level_Data");
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
